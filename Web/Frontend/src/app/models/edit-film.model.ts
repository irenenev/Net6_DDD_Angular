export class EditFilmModel {
    constructor(
        public id: number,
        public plot?: string,
        public actors?: string,
        public language?: string,
        public country?: string,
    ) {
        this.id = id;
        this.plot = plot;
        this.actors = actors;
        this.language = language;
        this.country = country;
    }
}
