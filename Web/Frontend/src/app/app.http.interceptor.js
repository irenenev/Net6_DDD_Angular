"use strict";
exports.__esModule = true;
exports.AppHttpInterceptor = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppHttpInterceptor = (function () {
    function AppHttpInterceptor(appAuthService) {
        this.appAuthService = appAuthService;
    }
    AppHttpInterceptor.prototype.intercept = function (request, next) {
        request = request.clone({
            setHeaders: { Authorization: "Bearer " + this.appAuthService.token() }
        });
        return next.handle(request);
    };
    AppHttpInterceptor = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppHttpInterceptor);
    return AppHttpInterceptor;
}());
exports.AppHttpInterceptor = AppHttpInterceptor;
//# sourceMappingURL=app.http.interceptor.js.map