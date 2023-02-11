import { Component, Input, OnInit } from "@angular/core";
import { FilmModel } from "src/app/models/film.model";
import { RouterModule } from '@angular/router';
import { AppAuthService } from "src/app/services/auth.service";
import { CommonModule } from "@angular/common";

@Component({
    selector: "app-img-card",
    templateUrl: './img-card.component.html',
    styleUrls: ['./img-card.component.css'],
    standalone: true,
    imports: [
        RouterModule,
        CommonModule
    ]
})

export class AppImgCardComponent implements OnInit {

    @Input()
    Film: FilmModel = new FilmModel;

    constructor(private readonly appAuthService: AppAuthService) { }

    userLoggedIn = false;

    ngOnInit() {
        this.userLoggedIn = this.appAuthService.authenticated();
    }
}
