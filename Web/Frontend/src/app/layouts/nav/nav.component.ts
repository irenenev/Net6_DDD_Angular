import { CommonModule } from "@angular/common";
import { Component, OnInit } from "@angular/core";
import { Router, RouterModule } from "@angular/router";
import { AppAuthService } from "src/app/services/auth.service";

@Component({
    selector: "app-nav",
    templateUrl: "./nav.component.html",
    standalone: true,
    imports: [
        RouterModule,
        CommonModule
    ]
})
export class AppNavComponent implements OnInit {
    constructor(private readonly appAuthService: AppAuthService,
        private router: Router) { }

    userLoggedIn = false;

    ngOnInit() {
        this.userLoggedIn = this.appAuthService.authenticated();
        this.router.routeReuseStrategy.shouldReuseRoute = () => false;
    }

    signout = () => this.appAuthService.signout();
}
