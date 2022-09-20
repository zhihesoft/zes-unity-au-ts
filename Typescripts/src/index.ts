import { TestForTS } from "csharp";
import "reflect-metadata";


const test = new TestForTS();
const hello = test.GetHello();
console.log(hello);
console.log(test.NoneFunc());

console.log("test end9!!");

export function i18n(id: number): string {
    return `id is ${id}`;
}

