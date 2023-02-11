"use strict";
exports.__esModule = true;
exports.FiltersModel = void 0;
var tslib_1 = require("tslib");
var filter_model_1 = require("./filter.model");
var FiltersModel = (function (_super) {
    tslib_1.__extends(FiltersModel, _super);
    function FiltersModel() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    FiltersModel.prototype.add = function (property, comparison, value) {
        if (!property || !value) {
            return;
        }
        this.removeIndex(this.findIndex(function (x) { return x.property === property && x.comparison === comparison; }));
        this.push(new filter_model_1.FilterModel(property, comparison, value));
    };
    FiltersModel.prototype.addFromFormGroup = function (form) {
        var _this = this;
        if (!form || !form.controls) {
            return;
        }
        Object.keys(form.controls).forEach(function (key) { return _this.add(key, "", form.controls[key].value); });
    };
    FiltersModel.prototype.remove = function (property) {
        if (!property) {
            return;
        }
        this.removeIndex(this.findIndex(function (x) { return x.property === property; }));
    };
    FiltersModel.prototype.removeIndex = function (index) {
        if (index < 0) {
            return;
        }
        this.splice(index, 1);
    };
    return FiltersModel;
}(Array));
exports.FiltersModel = FiltersModel;
//# sourceMappingURL=filters.model.js.map