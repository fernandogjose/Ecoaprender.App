import { Group } from "../group/group.dto";

export class Student {

    constructor(
        public id: number, 
        public name: string,
        public group: Group) { }
}