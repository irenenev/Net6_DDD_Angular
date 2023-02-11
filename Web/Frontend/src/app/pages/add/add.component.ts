import { CommonModule } from "@angular/common";
import { Component, Input, OnInit } from '@angular/core';
import {
    AbstractControl, FormsModule, ReactiveFormsModule,
    FormBuilder, FormControl, FormGroup, Validators
} from "@angular/forms";
import { AddFilmModel } from "src/app/models/add-film.model";
import { AppFilmService } from "../../services/film.service";
import { Router, RouterModule } from '@angular/router';

@Component({
    selector: 'app-add',
    templateUrl: './add.component.html',
    standalone: true,
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule
    ]
})
export class AddComponent implements OnInit {
    form: FormGroup = new FormGroup({
        title: new FormControl(''),
        year: new FormControl(2000),
        poster: new FormControl(''),
        genre: new FormControl(''),
        plot: new FormControl(''),
        actors: new FormControl(''),
        language: new FormControl(''),
        country: new FormControl('')
    });

    submitted = false;

    constructor(private filmService: AppFilmService,
        private formBuilder: FormBuilder,
        private router: Router) { }

    ngOnInit() {
        this.form = this.formBuilder.group({
            title: ['', [Validators.required, Validators.maxLength(100)]],
            year: [2000, [Validators.required, Validators.pattern('^[0-9]{4}$')]],
            poster: ['', [Validators.required, Validators.maxLength(200)]],
            genre: ['', [Validators.required, Validators.maxLength(50)]],
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

    add() {
        this.submitted = true;

        if (this.form.invalid) return;

        this.filmService.add(this.form.value as AddFilmModel).subscribe((id) => {
            this.router.navigate([`/film/detail/${id}`]);
        });
    }
}
