import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AppFilmService } from "../../services/film.service";
import { GetFilmModel } from "../../models/get-film.model";
import { RouterModule } from '@angular/router';

@Component({
    selector: 'app-delete',
    templateUrl: './delete.component.html',
    standalone: true,
    imports: [
        RouterModule
    ]
})
export class DeleteComponent implements OnInit {

    id!: number;
    Film: GetFilmModel = new GetFilmModel;
    returnUrl!: string;

    constructor(private route: ActivatedRoute,
        private filmService: AppFilmService,
        private router: Router) {
        this.route.params.subscribe(params => this.id = params['id']);
    }

    ngOnInit() {
        this.filmService.get(this.id).subscribe(data => this.Film = data);
    }

    delete() {
        this.filmService.delete(this.id).subscribe(() => {
            this.router.navigate(['/'])
        });
    }
}
