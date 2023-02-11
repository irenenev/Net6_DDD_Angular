"use strict";
exports.__esModule = true;
exports.AppFilmService = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppFilmService = (function () {
    function AppFilmService(http, gridService) {
        var _this = this;
        this.http = http;
        this.gridService = gridService;
        this.add = function (film) { return _this.http.post("film", film); };
        this["delete"] = function (id) { return _this.http["delete"]("film/" + id); };
        this.get = function (id) { return _this.http.get("film/" + id); };
        this.grid = function (parameters) { return _this.gridService.get("film/grid", parameters); };
        this.list = function () { return _this.http.get("film"); };
        this.update = function (film) { return _this.http.put("film/" + film.id, film); };
    }
    AppFilmService = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppFilmService);
    return AppFilmService;
}());
exports.AppFilmService = AppFilmService;
//# sourceMappingURL=film.service.js.map