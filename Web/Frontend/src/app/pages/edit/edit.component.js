"use strict";
exports.__esModule = true;
exports.EditComponent = void 0;
var tslib_1 = require("tslib");
var common_1 = require("@angular/common");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var edit_film_model_1 = require("../../models/edit-film.model");
var get_film_model_1 = require("../../models/get-film.model");
var EditComponent = (function () {
    function EditComponent(filmService, formBuilder, route, router) {
        var _this = this;
        this.filmService = filmService;
        this.formBuilder = formBuilder;
        this.route = route;
        this.router = router;
        this.form = new forms_1.FormGroup({
            plot: new forms_1.FormControl(''),
            actors: new forms_1.FormControl(''),
            language: new forms_1.FormControl(''),
            country: new forms_1.FormControl('')
        });
        this.submitted = false;
        this.Film = new get_film_model_1.GetFilmModel;
        this.route.params.subscribe(function (params) { return _this.id = params['id']; });
    }
    EditComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.filmService.get(this.id).subscribe(function (data) { return _this.Film = data; });
        this.form = this.formBuilder.group({
            plot: ['', forms_1.Validators.maxLength(1000)],
            actors: ['', forms_1.Validators.maxLength(200)],
            language: ['', forms_1.Validators.maxLength(50)],
            country: ['', forms_1.Validators.maxLength(50)]
        });
    };
    Object.defineProperty(EditComponent.prototype, "f", {
        get: function () {
            return this.form.controls;
        },
        enumerable: false,
        configurable: true
    });
    EditComponent.prototype.edit = function () {
        var _this = this;
        this.submitted = true;
        if (this.form.invalid)
            return;
        var data = new edit_film_model_1.EditFilmModel(this.id, this.form.value.plot, this.form.value.actors, this.form.value.language, this.form.value.country);
        this.filmService.update(data).subscribe(function () {
            _this.submitted = false;
            _this.router.navigate(["/film/detail/" + _this.id]);
        });
    };
    EditComponent.prototype.onReset = function () {
        this.submitted = false;
        this.form.reset();
    };
    tslib_1.__decorate([
        core_1.Input()
    ], EditComponent.prototype, "f");
    EditComponent = tslib_1.__decorate([
        core_1.Component({
            selector: 'app-edit',
            templateUrl: './edit.component.html',
            standalone: true,
            imports: [
                common_1.CommonModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                router_1.RouterModule
            ]
        })
    ], EditComponent);
    return EditComponent;
}());
exports.EditComponent = EditComponent;
//# sourceMappingURL=edit.component.js.map