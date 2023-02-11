import { CommonModule } from "@angular/common";
import { Component, Input, OnInit } from '@angular/core';
import { Router, ActivatedRoute, RouterModule } from '@angular/router';
import { AbstractControl, FormsModule, ReactiveFormsModule, FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { EditFilmModel } from "../../models/edit-film.model";
import { GetFilmModel } from "../../models/get-film.model";
import { AppFilmService } from "../../services/film.service";

@Component({
    selector: 'app-edit',
    templateUrl: './edit.component.html',
    standalone: true,
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule
    ]
})
export class EditComponent implements OnInit {
    form: FormGroup = new FormGroup({
        plot: new FormControl(''),
        actors: new FormControl(''),
        language: new FormControl(''),
        country: new FormControl('')
    });

    submitted = false;
    id!: number;
    Film: GetFilmModel = new GetFilmModel;

    constructor(private filmService: AppFilmService,
        private formBuilder: FormBuilder,
        private route: ActivatedRoute,
        private router: Router) {
        this.route.params.subscribe(params => this.id = params['id']);
    }

    ngOnInit() {
        this.filmService.get(this.id).subscribe(data => this.Film = data);
        this.form = this.formBuilder.group({
            plot: ['', Validators.maxLength(1000)],
            actors: ['', Validators.maxLength(200)],
            language: ['', Validators.maxLength(50)],
            country: ['', Validators.maxLength(50)]
        });
    }

    @Input()
    get f(): { [key: string]: AbstractControl } {
        return this.form.controls;
    }

    edit() {
        this.submitted = true;

        if (this.form.invalid) return;

        const data = new EditFilmModel(
            this.id,
            this.form.value.plot,
            this.form.value.actors,
            this.form.value.language,
            this.form.value.country
        );

        this.filmService.update(data).subscribe(() => {
            this.submitted = false;
            this.router.navigate([`/film/detail/${this.id}`]);
        });
    }

    onReset() {
        this.submitted = false;
        this.form.reset();
    }
}
