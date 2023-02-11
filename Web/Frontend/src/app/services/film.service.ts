import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { GridParametersModel } from "src/app/components/grid/grid-parameters.model";
import { GridService } from "src/app/components/grid/grid.service";
import { FilmModel } from "src/app/models/film.model";
import { AddFilmModel } from "src/app/models/add-film.model";
import { GetFilmModel } from "src/app/models/get-film.model";
import { EditFilmModel } from "src/app/models/edit-film.model";

@Injectable({ providedIn: "root" })
export class AppFilmService {
    constructor(
        private readonly http: HttpClient,
        private readonly gridService: GridService) { }

    add = (film: AddFilmModel) => this.http.post<number>("film", film);

    delete = (id: number) => this.http.delete(`film/${id}`);

    get = (id: number) => this.http.get<GetFilmModel>(`film/${id}`);

    grid = (parameters: GridParametersModel) => this.gridService.get<FilmModel>(`film/grid`, parameters);

    list = () => this.http.get<FilmModel[]>("film");

    update = (film: EditFilmModel) => this.http.put(`film/${film.id}`, film);
}
