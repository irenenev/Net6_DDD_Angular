"use strict";
exports.__esModule = true;
exports.OrderModel = void 0;
var OrderModel = (function () {
    function OrderModel(property, ascending) {
        if (property === void 0) { property = ""; }
        if (ascending === void 0) { ascending = true; }
        this.property = property;
        this.ascending = ascending;
    }
    return OrderModel;
}());
exports.OrderModel = OrderModel;
//# sourceMappingURL=order.model.js.map