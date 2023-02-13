import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { AuthModel } from "src/app/models/auth.model";

@Injectable({ providedIn: "root" })
export class AppAuthService {
    constructor(
        private readonly http: HttpClient,
        private readonly router: Router) { }

    authenticated = () => !!this.token();

    auth(auth: AuthModel): void {
        this.http
            .post("auths/login", auth)
            .subscribe((result: any) => {
                if (!result || !result.token) return;
                localStorage.setItem("token", result.token);
                this.router.navigate(["/"]);
            });
    }

    register(auth: AuthModel): void {
        this.http
            .post("auths/register", auth)
            .subscribe((result: any) => {
                if (!result || !result.token) return;
                localStorage.setItem("token", result.token);
                this.router.navigate(["/"]);
            });
    }

    signin = () => this.router.navigate(["/login"]);

    signout() {
        localStorage.clear();
        this.signin();
    }

    token = () => localStorage.getItem("token");
}
