import { Component, HostListener, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({ selector: 'app-navbar', templateUrl: './navbar.component.html', styleUrls: ['./navbar.component.scss'] })
export class NavbarComponent implements OnInit {
  scrolled = false;
  menuOpen = false;

  constructor(public auth: AuthService, private router: Router) {}
  ngOnInit() {}

  @HostListener('window:scroll')
  onScroll() { this.scrolled = window.scrollY > 50; }

  logout() { this.auth.logout(); this.router.navigate(['/home']); }
  toggleMenu() { this.menuOpen = !this.menuOpen; }
  closeMenu() { this.menuOpen = false; }
}
