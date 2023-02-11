"use strict";
exports.__esModule = true;
exports.DetailComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var get_film_model_1 = require("../../models/get-film.model");
var router_1 = require("@angular/router");
var DetailComponent = (function () {
    function DetailComponent(route, filmService) {
        var _this = this;
        this.route = route;
        this.filmService = filmService;
        this.Film = new get_film_model_1.GetFilmModel;
        this.route.params.subscribe(function (params) { return _this.id = params['id']; });
    }
    DetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.filmService.get(this.id).subscribe(function (data) { return _this.Film = data; });
    };
    DetailComponent = tslib_1.__decorate([
        core_1.Component({
            selector: 'app-detail',
            templateUrl: './detail.component.html',
            standalone: true,
            imports: [
                router_1.RouterModule
            ]
        })
    ], DetailComponent);
    return DetailComponent;
}());
exports.DetailComponent = DetailComponent;
//# sourceMappingURL=detail.component.js.map