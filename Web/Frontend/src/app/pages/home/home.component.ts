import { Component } from "@angular/core";
import { AppImgListComponent } from "./img-list/img-list.component";
import { RouterModule } from '@angular/router';

@Component({
    selector: "app-home",
    templateUrl: "./home.component.html",
    standalone: true,
    imports: [
        RouterModule,
        AppImgListComponent
    ]
})
export class AppHomeComponent { }
