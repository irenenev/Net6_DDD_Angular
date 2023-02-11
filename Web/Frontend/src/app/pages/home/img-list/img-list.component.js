"use strict";
exports.__esModule = true;
exports.AppImgListComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var img_card_component_1 = require("src/app/pages/home/img-card/img-card.component");
var common_1 = require("@angular/common");
var router_1 = require("@angular/router");
var AppImgListComponent = (function () {
    function AppImgListComponent(filmService) {
        this.filmService = filmService;
        this.FilmArr = [];
    }
    AppImgListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.filmService.list().subscribe(function (data) { return _this.FilmArr = data; });
    };
    AppImgListComponent = tslib_1.__decorate([
        core_1.Component({
            selector: "app-img-list",
            templateUrl: "./img-list.component.html",
            standalone: true,
            imports: [
                img_card_component_1.AppImgCardComponent,
                common_1.CommonModule,
                router_1.RouterModule
            ]
        })
    ], AppImgListComponent);
    return AppImgListComponent;
}());
exports.AppImgListComponent = AppImgListComponent;
//# sourceMappingURL=img-list.component.js.map