import { CommonModule } from "@angular/common";
import { Component, inject } from "@angular/core";
import { FormBuilder, FormControl, ReactiveFormsModule } from "@angular/forms";
import { RouterModule } from '@angular/router';
import { debounceTime } from "rxjs/operators";
import { AppInputTextComponent } from "src/app/components/input/text.input.component";
import { AppOrderComponent } from "src/app/components/grid/order/order.component";
import { AppPageComponent } from "src/app/components/grid/page/page.component";
import { AppFilmService } from "src/app/services/film.service";
import { GridModel } from "src/app/components/grid/grid.model";
import { GridParametersModel } from "src/app/components/grid/grid-parameters.model";
import { FilmModel } from "src/app/models/film.model";
import { AppAuthService } from "src/app/services/auth.service";

@Component({
    selector: "app-list-grid",
    templateUrl: "./grid.component.html",
    standalone: true,
    imports: [
        CommonModule,
        RouterModule,
        ReactiveFormsModule,
        AppOrderComponent,
        AppPageComponent,
        AppInputTextComponent
    ]
})
export class AppListGridComponent {
    filters = inject(FormBuilder).group({
        Id: new FormControl(),
        Title: new FormControl(),
        Year: new FormControl(),
        Genre: new FormControl()
    });

    grid = new GridModel<FilmModel>();
    userLoggedIn = false;

    constructor(private readonly appFilmService: AppFilmService,
        private readonly appAuthService: AppAuthService) {
        this.init();
    }

    load() {
        this.appFilmService.grid(this.grid.parameters).subscribe((grid) => this.grid = grid);
    }

    private filter() {
        this.grid.parameters = new GridParametersModel();
        this.grid.parameters.filters.addFromFormGroup(this.filters);
        this.load();
    }

    private init() {
        this.grid.parameters.order.property = "Id";
        this.filters.valueChanges.pipe(debounceTime(0)).subscribe(() => this.filter());
        this.userLoggedIn = this.appAuthService.authenticated();
        this.load();
    }
}
