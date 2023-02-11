"use strict";
exports.__esModule = true;
exports.AppImgCardComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var film_model_1 = require("src/app/models/film.model");
var router_1 = require("@angular/router");
var common_1 = require("@angular/common");
var AppImgCardComponent = (function () {
    function AppImgCardComponent(appAuthService) {
        this.appAuthService = appAuthService;
        this.Film = new film_model_1.FilmModel;
        this.userLoggedIn = false;
    }
    AppImgCardComponent.prototype.ngOnInit = function () {
        this.userLoggedIn = this.appAuthService.authenticated();
    };
    tslib_1.__decorate([
        core_1.Input()
    ], AppImgCardComponent.prototype, "Film");
    AppImgCardComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-img-card",
            templateUrl: './img-card.component.html',
            styleUrls: ['./img-card.component.css'],
            standalone: true,
            imports: [
                router_1.RouterModule,
                common_1.CommonModule
            ]
        })
    ], AppImgCardComponent);
    return AppImgCardComponent;
}());
exports.AppImgCardComponent = AppImgCardComponent;
//# sourceMappingURL=img-card.component.js.map