"use strict";
exports.__esModule = true;
exports.AppAuthService = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppAuthService = (function () {
    function AppAuthService(http, router) {
        var _this = this;
        this.http = http;
        this.router = router;
        this.authenticated = function () { return !!_this.token(); };
        this.signin = function () { return _this.router.navigate(["/login"]); };
        this.token = function () { return localStorage.getItem("token"); };
    }
    AppAuthService.prototype.auth = function (auth) {
        var _this = this;
        this.http
            .post("auths/login", auth)
            .subscribe(function (result) {
            if (!result || !result.token)
                return;
            localStorage.setItem("token", result.token);
            _this.router.navigate(["/"]);
        });
    };
    AppAuthService.prototype.signout = function () {
        localStorage.clear();
        this.signin();
    };
    AppAuthService = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppAuthService);
    return AppAuthService;
}());
exports.AppAuthService = AppAuthService;
//# sourceMappingURL=auth.service.js.map