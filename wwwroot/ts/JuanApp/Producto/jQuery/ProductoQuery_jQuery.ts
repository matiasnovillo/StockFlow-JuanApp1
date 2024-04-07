//Import libraries to use
import { ProductoEntity } from "../TsEntities/Producto_TsEntity";
import { paginatedProductoDTO } from "../DTOs/paginatedProductoDTO";
import * as $ from "jquery";
import * as Rx from "rxjs";
import { ajax } from "rxjs/ajax";
import { Ajax } from "../../../Library/Ajax";
import "bootstrap-notify";

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

//Set default values
let TextToSearch: string = "";
let IsStrictSearch: boolean = false;
let PageIndex: number = 0;
let PageSize: number = 0;
let ViewToggler: string = "List";
let TotalItems: number = 0;

class ProductoQuery {
    static GetAllPaginated(request_paginatedProductoDTO: paginatedProductoDTO) {

        var ListContent: string = ``;

        ProductoEntity.GetAllPaginated(request_paginatedProductoDTO).subscribe(
            {
                next: newrow => {
                    //Only works when there is data available
                    if (newrow.status != 204) {

                        const response_productoQuery = newrow.response as paginatedProductoDTO;

                        //Set to default values if they are null
                        TextToSearch = response_productoQuery.TextToSearch ?? "";
                        IsStrictSearch = response_productoQuery.IsStrictSearch ?? false;
                        PageIndex = response_productoQuery.PageIndex ?? 0;
                        PageSize = response_productoQuery.PageSize ?? 0;
                        TotalItems = response_productoQuery.TotalItems ?? 0;

                        //Query string
                        $("#query-string").attr("placeholder", `Buscar producto por ProductoId... (${TotalItems} producto in this page)`);

                        //If book is empty set to default pagination values
                        if (response_productoQuery?.lstProducto?.length === 0) {
                            
                        }
                        //Read data book
                        response_productoQuery?.lstProducto?.forEach(row => {

                            ListContent += `
<div class="row">
    <div class="col-12">
        <div class="card bg-gradient-dark h-100">
            <div class="card-header bg-transparent text-sm-start text-center pt-4 pb-3 px-4">
                <h6 class="mb-1 text-white">ID: ${row.ProductoId}</h6>
            </div>
            <hr class="horizontal light my-0">
            <div class="card-body">
                <span class="text-white text-light mb-4">
                           ProductoId <i class="fas fa-key"></i> ${row.ProductoId}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           Active <i class="fas fa-toggle-on"></i> ${row.Active == true ? "Active <i class='text-success fas fa-circle'></i>" : "Not active <i class='text-danger fas fa-circle'></i>"}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           DateTimeCreation <i class="fas fa-calendar"></i> ${row.DateTimeCreation}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           DateTimeLastModification <i class="fas fa-calendar"></i> ${row.DateTimeLastModification}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           UserCreationId <i class="fas fa-key"></i> ${row.UserCreationId}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           UserLastModificationId <i class="fas fa-key"></i> ${row.UserLastModificationId}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           Nombre <i class="fas fa-font"></i> ${row.Nombre}
                        </span>
                        <br/>
                        <span class="text-white mb-4">
                           CodigoProducto <i class="fas fa-font"></i> ${row.CodigoProducto}
                        </span>
                        <br/>
                        
            </div>
        </div>
    </div>
</div>`;
                        })

                        //If view table is activated, clear table view, if not, clear list view
                        if (ViewToggler === "Table") {
                        }
                        else {
                            $("#body-list").html(ListContent);
                        }
                    }
                    else {
                        //ERROR
                        // @ts-ignore
                        $.notify({ icon: "fas fa-exclamation-triangle", message: "No registers found" }, { type: "warning", placement: { from: "bottom", align: "center" } });
                    }
                },
                complete: () => {

                    //Check button inside list view
                    $(".checkbox-list").on("click", function (e) {
                        //Toggler
                        if ($(this).hasClass("list-row-checked")) {
                            $(this).html(`<a class="icon icon-shape bg-white icon-sm rounded-circle shadow" href="javascript:void(0)" role="button" data-toggle="tooltip" data-original-title="check">
                                                            <i class="fas fa-circle text-white"></i>
                                                        </a>`);
                            $(this).removeClass("list-row-checked").addClass("list-row-unchecked");
                        }
                        else {
                            $(this).html(`<a class="icon icon-shape bg-white icon-sm text-primary rounded-circle shadow" href="javascript:void(0)" role="button" data-toggle="tooltip" data-original-title="check">
                                                            <i class="fas fa-check"></i>
                                                        </a>`);
                            $(this).removeClass("list-row-unchecked").addClass("list-row-checked");
                        }
                    });

                    //Check all button inside table
                    $("#table-check-all").on("click", function (e) { 
                        //Toggler
                        if ($("tr td div input.table-checkbox-for-row").is(":checked")) {
                            $("tr td div input.table-checkbox-for-row").removeAttr("checked");
                        }
                        else {
                            $("tr td div input.table-checkbox-for-row").attr("checked", "checked");
                        }
                    });

                    //Buttons inside head of table
                    $("tr th button").one("click", function (e) {
                        ValidateAndSearch();
                    });

                    //Delete button in table and list
                    $("div.dropdown-menu button.table-delete-button, div.dropdown-menu button.list-delete-button").on("click", function (e) {
                        let ProductoId = $(this).val();
                        ProductoEntity.DeleteByProductoId(ProductoId).subscribe({
                            next: newrow => {
                            },
                            complete: () => {
                                //SUCCESS
                                // @ts-ignore
                                $.notify({ icon: "fas fa-check", message: "Row deleted successfully" }, { type: "success", placement: { from: "bottom", align: "center" } });

                                ValidateAndSearch();
                            },
                            error: err => {
                                //ERROR
                                // @ts-ignore
                                $.notify({ icon: "fas fa-exclamation-triangle", message: "There was an error while trying to delete data" }, { type: "danger", placement: { from: "bottom", align: "center" } });
                                console.log(err);
                            }
                        });
                    });

                    //Copy button in table and list
                    $("div.dropdown-menu button.table-copy-button, div.dropdown-menu button.list-copy-button").on("click", function (e) {
                        let ProductoId = $(this).val();
                        ProductoEntity.CopyByProductoId(ProductoId).subscribe({
                            next: newrow => {
                            },
                            complete: () => {
                                //SUCCESS
                                // @ts-ignore
                                $.notify({ icon: "fas fa-check", message: "Row copied successfully" }, { type: "success", placement: { from: "bottom", align: "center" } });

                                ValidateAndSearch();
                            },
                            error: err => {
                                //ERROR
                                // @ts-ignore
                                $.notify({ icon: "fas fa-exclamation-triangle", message: "There was an error while trying to copy data" }, { type: "danger", placement: { from: "bottom", align: "center" } });
                                console.log(err);
                            }
                        });
                    });
                },
                error: err => {
                    //ERROR
                    // @ts-ignore
                    $.notify({ icon: "fas fa-exclamation-triangle", message: "There was an error while trying to get data" }, { type: "danger", placement: { from: "bottom", align: "center" } });
                    console.log(err);
                }
            });
    }
}

function ValidateAndSearch() {

    var _productoSelectAllPaged: paginatedProductoDTO = {
        lstProducto: [],
        lstUserCreation: [],
        lstUserLastModification: [],
        TextToSearch,
        IsStrictSearch,
        PageIndex,
        PageSize,
        TotalItems
    };

    ProductoQuery.GetAllPaginated(_productoSelectAllPaged);
}

//LOAD EVENT
if ($("#title-page").html().includes("Buscar producto")) {
    //Set to default values
    TextToSearch = "";
    IsStrictSearch = false;
    PageIndex = 1;
    PageSize = 15;
    ViewToggler = "List";
    TotalItems = 0;

    ValidateAndSearch();
}
//CLICK, SCROLL AND KEYBOARD EVENTS
//Search button
$($("#search-button")).on("click", function () {
    ValidateAndSearch();
});

//Query string
$("#query-string").on("change keyup input", function (e) {
    //If undefined, set TextToSearch to "" value
    TextToSearch = ($(this).val()?.toString()) ?? "" ;
    ValidateAndSearch();
});

//Table view button
$("#table-view-button").on("click", function (e) {
    $("#view-toggler").val("Table");
    ViewToggler = "Table";
    //Clear table view
    $("#body-and-head-table").html("");
    ValidateAndSearch();
});

//List view button
$("#list-view-button").on("click", function (e) {
    $("#view-toggler").val("List");
    ViewToggler = "List";
    //Clear list view
    $("#body-list").html("");
    ValidateAndSearch();
});