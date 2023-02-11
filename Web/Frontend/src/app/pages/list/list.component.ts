import { Component } from "@angular/core";
import { AppListGridComponent } from "./grid/grid.component";
import { RouterModule } from '@angular/router';

@Component({
    selector: "app-list",
    templateUrl: "./list.component.html",
    standalone: true,
    imports: [
        RouterModule,
        AppListGridComponent
    ]
})
export class AppListComponent { }
