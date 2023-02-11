"use strict";
exports.__esModule = true;
exports.DeleteComponent = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var get_film_model_1 = require("../../models/get-film.model");
var router_1 = require("@angular/router");
var DeleteComponent = (function () {
    function DeleteComponent(route, filmService, router) {
        var _this = this;
        this.route = route;
        this.filmService = filmService;
        this.router = router;
        this.Film = new get_film_model_1.GetFilmModel;
        this.route.params.subscribe(function (params) { return _this.id = params['id']; });
    }
    DeleteComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.filmService.get(this.id).subscribe(function (data) { return _this.Film = data; });
    };
    DeleteComponent.prototype["delete"] = function () {
        var _this = this;
        this.filmService["delete"](this.id).subscribe(function () {
            _this.router.navigate(['/']);
        });
    };
    DeleteComponent = tslib_1.__decorate([
        core_1.Component({
            selector: 'app-delete',
            templateUrl: './delete.component.html',
            standalone: true,
            imports: [
                router_1.RouterModule
            ]
        })
    ], DeleteComponent);
    return DeleteComponent;
}());
exports.DeleteComponent = DeleteComponent;
//# sourceMappingURL=delete.component.js.map