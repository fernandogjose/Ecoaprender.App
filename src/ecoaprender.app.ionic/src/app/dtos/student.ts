import { Group } from "./group";

export class Student {

    constructor(
        public id: number, 
        public name: string,
        public group: Group) { }
}