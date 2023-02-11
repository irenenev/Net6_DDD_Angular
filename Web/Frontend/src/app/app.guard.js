"use strict";
exports.__esModule = true;
exports.AppGuard = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppGuard = (function () {
    function AppGuard(appAuthService) {
        this.appAuthService = appAuthService;
    }
    AppGuard.prototype.canActivate = function () {
        if (this.appAuthService.authenticated()) {
            return true;
        }
        this.appAuthService.signin();
        return false;
    };
    AppGuard = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppGuard);
    return AppGuard;
}());
exports.AppGuard = AppGuard;
//# sourceMappingURL=app.guard.js.map