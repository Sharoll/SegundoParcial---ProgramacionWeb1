import { Pago } from "./pago";

export class Persona {
    constructor(){
        this.pago = new Pago();
    }
    tipoDocumento: string;
    identificacion: string;
    nombre: string;
    direccion: string;
    telefono: string;
    pais: string;
    departamento: string;
    ciudad: string;
    pago: Pago;
    
}