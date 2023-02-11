"use strict";
exports.__esModule = true;
exports.AppModalService = void 0;
var tslib_1 = require("tslib");
var core_1 = require("@angular/core");
var AppModalService = (function () {
    function AppModalService() {
        this.alert = function (message) { return UIkit.modal.alert(message); };
    }
    AppModalService = tslib_1.__decorate([
        core_1.Injectable({ providedIn: "root" })
    ], AppModalService);
    return AppModalService;
}());
exports.AppModalService = AppModalService;
//# sourceMappingURL=modal.service.js.map