import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AppFilmService } from "../../services/film.service";
import { GetFilmModel } from "../../models/get-film.model";
import { RouterModule } from '@angular/router';

@Component({
    selector: 'app-detail',
    templateUrl: './detail.component.html',
    standalone: true,
    imports: [
        RouterModule
    ]
})
export class DetailComponent implements OnInit {

    id!: number;
    Film: GetFilmModel = new GetFilmModel;

    constructor(private route: ActivatedRoute,
        private filmService: AppFilmService) {
        this.route.params.subscribe(params => this.id = params['id']);
    }

    ngOnInit() {
        this.filmService.get(this.id).subscribe(data => this.Film = data);
    }
}
