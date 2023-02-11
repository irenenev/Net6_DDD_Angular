import { Component, OnInit } from '@angular/core';
import { AppFilmService } from "src/app/services/film.service";
import { FilmModel } from "src/app/models/film.model";
import { AppImgCardComponent } from "src/app/pages/home/img-card/img-card.component"
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
    selector: "app-img-list",
    templateUrl: "./img-list.component.html",
    standalone: true,
    imports: [
        AppImgCardComponent,
        CommonModule,
        RouterModule
    ]
})
export class AppImgListComponent implements OnInit {

    FilmArr: Array<FilmModel> = [];
    constructor(private filmService: AppFilmService) { }

    ngOnInit(): void {
        this.filmService.list().subscribe((data) => this.FilmArr = data);
    }
}
