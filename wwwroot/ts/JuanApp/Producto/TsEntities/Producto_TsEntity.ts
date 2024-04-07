import * as Rx from "rxjs";
import { ajax } from "rxjs/ajax";
import { Ajax } from "../../../Library/Ajax";
import { paginatedProductoDTO } from "../DTOs/paginatedProductoDTO";

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
*/

export class ProductoEntity {

    //Fields
    ProductoId?: number;
    Active?: boolean;
    DateTimeCreation?: string | string[] | number | undefined;
    DateTimeLastModification?: string | string[] | number | undefined;
    UserCreationId?: number;
    UserLastModificationId?: number;
    Nombre?: string | string[] | number | undefined;
    CodigoProducto?: string | string[] | number | undefined;
    

    //Queries
    static GetByProductoId(ProductoId: number) {
        let URL = "/api/JuanApp/Producto/1/GetByProductoId/" + ProductoId;
        return Rx.from(ajax(URL));
    }

    static GetAll() {
        let URL = "/api/JuanApp/Producto/1/GetAll"
        return Rx.from(ajax(URL));
    }
    
    static GetAllPaginated(paginatedProductoDTO: paginatedProductoDTO) {
        let URL = "/api/JuanApp/Producto/1/GetAllPaginated";
        let Body = {
            "lstProducto": paginatedProductoDTO.lstProducto,
            "lstUserCreation": paginatedProductoDTO.lstUserCreation,
            "lstUserLastModification": paginatedProductoDTO.lstUserLastModification,
            "TextToSearch": paginatedProductoDTO.TextToSearch,
            "IsStrictSearch": paginatedProductoDTO.IsStrictSearch,
            "PageIndex": paginatedProductoDTO.PageIndex,
            "PageSize": paginatedProductoDTO.PageSize
        };
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }

    //Non-Queries
    static AddOrUpdate(Body: Ajax) {
        let URL = "/api/JuanApp/Producto/1/AddOrUpdate";
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }

    static DeleteByProductoId(ProductoId: number | string | string[] | undefined) {
        let URL = "/api/JuanApp/Producto/1/DeleteByProductoId/" + ProductoId;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.delete(URL, Header));
    }

    static DeleteManyOrAll(DeleteType: string, Body: Ajax) {
        let URL = "/api/JuanApp/Producto/1/DeleteManyOrAll/" + DeleteType;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }
    
    static CopyByProductoId(ProductoId: string | number | string[] | undefined) {
        let URL = "/api/JuanApp/Producto/1/CopyByProductoId/" + ProductoId;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        let Body: any = {};
        return Rx.from(ajax.post(URL, Body, Header));
    }

    static CopyManyOrAll(CopyType: string, Body: Ajax) {
        let URL = "/api/JuanApp/Producto/1/CopyManyOrAll/" + CopyType;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }

    //Exportations
    static ExportAsPDF(ExportationType: string, Body: Ajax) {
        let URL = "/api/JuanApp/Producto/1/ExportAsPDF/" + ExportationType;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }

    static ExportAsExcel(ExportationType: string, Body: Ajax) {
        let URL = "/api/JuanApp/Producto/1/ExportAsExcel/" + ExportationType;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }

    static ExportAsCSV(ExportationType: string, Body: Ajax) {
        let URL = "/api/JuanApp/Producto/1/ExportAsCSV/" + ExportationType;
        let Header: any = {
            "Accept": "application/json",
            "Content-Type": "application/json; charset=utf-8"
        };
        return Rx.from(ajax.post(URL, Body, Header));
    }
}