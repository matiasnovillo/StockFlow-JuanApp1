import { UserEntity } from "../../../CMSCore/User_TsEntity";
import { ProductoEntity } from "../TsEntities/Producto_TsEntity";

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

export class paginatedProductoDTO {
    lstProducto?: ProductoEntity[] | undefined;
    lstUserCreation?: UserEntity[] | undefined;
    lstUserLastModification?: UserEntity[] | undefined;
    TextToSearch?: string;
    IsStrictSearch?: boolean;
    PageIndex?: number;
    PageSize?: number;
    TotalItems?: number;
}