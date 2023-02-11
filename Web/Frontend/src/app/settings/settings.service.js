"use strict";
exports.__esModule = true;
exports.AppSettingsService = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppSettingsService = (function () {
    function AppSettingsService(http) {
        var _this = this;
        this.http = http;
        this.http.get("./assets/settings.json").subscribe(function (settings) { return _this.settings = settings; });
    }
    AppSettingsService = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppSettingsService);
    return AppSettingsService;
}());
exports.AppSettingsService = AppSettingsService;
//# sourceMappingURL=settings.service.js.map