import { Component, OnInit } from '@angular/core';
import { MenuService } from '../../services/menu.service';

@Component({ selector: 'app-home', templateUrl: './home.component.html', styleUrls: ['./home.component.scss'] })
export class HomeComponent implements OnInit {
  specials: any[] = [];
  foodImages = [
    'https://images.unsplash.com/photo-1546069901-ba9599a7e63c?w=400',
    'https://images.unsplash.com/photo-1565299624946-b28f40a0ae38?w=400',
    'https://images.unsplash.com/photo-1567620905732-2d1ec7ab7445?w=400',
    'https://images.unsplash.com/photo-1504674900247-0877df9cc836?w=400',
    'https://images.unsplash.com/photo-1476224203421-9ac39bcb3327?w=400',
    'https://images.unsplash.com/photo-1414235077428-338989a2e8c0?w=400',
  ];
  constructor(private menuService: MenuService) {}
  ngOnInit() {
    this.menuService.getSpecials().subscribe({ next: (d) => this.specials = d.slice(0,4), error: () => {} });
  }
  getImage(i: number) { return this.specials[i]?.imageUrl || this.foodImages[i % this.foodImages.length]; }
}
