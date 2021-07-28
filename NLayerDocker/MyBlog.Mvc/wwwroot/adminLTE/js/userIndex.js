﻿$(document).ready(function () {
    const dataTable = $('#usersTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: "Ekle",
                attr: {
                    id: "btnAdd"
                },
                className: "btn btn-sm btn-success",
                action: function (e, dt, node, config) {
                }
            },
            {
                text: "Yenile",
                className: "btn btn-sm btn-warning",
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: "GET",
                        url: '/Admin/User/GetAllUsers',
                        contentType: "application/json",
                        beforeSend: function () {
                            $("#usersTable").hide();
                            $(".spinner-border").show();
                        },
                        success: function (data) {
                            const userListDto = jQuery.parseJSON(data);
                            //Data Table üzerinde ki dataları sıfırlıyoruz
                            dataTable.clear();

                            if (userListDto.ResultStatus === 0) {
                                $.each(userListDto.Users.$values, function (index, user) {

                                    const newTableRow = dataTable.row.add([
                                        user.Id,
                                        user.UserName,
                                        user.Email,
                                        user.FirstName,
                                        user.LastName,
                                        user.PhoneNumber,
                                        user.About.length > 75 ? user.About.substring(0, 75) : user.About,
                                        `<img src="/img/${user.Picture}" alt="${user.UserName}" class="my-image-table" />`,
                                        `
                                <button class="btn btn-info btn-sm btn-detail" data-id="${user.Id}"><span class="fas fa-newspaper"></span></button>
                                <button class="btn btn-warning btn-sm btn-assign" data-id="${user.Id}"><span class="fas fa-user-shield"></span></button>
                                <button class="btn btn-primary btn-sm btn-update" data-id="${user.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${user.Id}"><span class="fas fa-minus-circle"></span></button>
                                            `
                                    ]).node(); //Node ile eklenen tr satırına erişebiliyoruz

                                    const jqueryTableRow = $(newTableRow);
                                    jqueryTableRow.attr("name", `${user.Id}`);

                                });

                                dataTable.draw(); //Eklenen dataları tabloya uyarlıyoruz
                                $(".spinner-border").hide();
                                $("#usersTable").fadeIn(1000);
                            }
                            else {
                                toastr.error(`${userListDto.Message}`, "İşlem Başarısız!");
                            }
                        },
                        error: function (err) {
                            $(".spinner-border").hide();
                            $("#usersTable").fadeIn(1000);
                            toastr.error(`${err.responseText}`, "Hata!");
                            $(".spinner-border").hide();
                        }
                    });
                }
            }
        ],
        language: {
            "emptyTable": "Tabloda herhangi bir veri mevcut değil",
            "info": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "infoEmpty": "Kayıt yok",
            "infoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "infoThousands": ".",
            "lengthMenu": "Sayfada _MENU_ kayıt göster",
            "loadingRecords": "Yükleniyor...",
            "processing": "İşleniyor...",
            "search": "Ara:",
            "zeroRecords": "Eşleşen kayıt bulunamadı",
            "paginate": {
                "first": "İlk",
                "last": "Son",
                "next": "Sonraki",
                "previous": "Önceki"
            },
            "aria": {
                "sortAscending": ": artan sütun sıralamasını aktifleştir",
                "sortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "1": "1 kayıt seçildi",
                    "0": "-"
                },
                "0": "-",
                "1": "%d satır seçildi",
                "2": "-",
                "_": "%d satır seçildi",
                "cells": {
                    "1": "1 hücre seçildi",
                    "_": "%d hücre seçildi"
                },
                "columns": {
                    "1": "1 sütun seçildi",
                    "_": "%d sütun seçildi"
                }
            },
            "autoFill": {
                "cancel": "İptal",
                "fillHorizontal": "Hücreleri yatay olarak doldur",
                "fillVertical": "Hücreleri dikey olarak doldur",
                "info": "-",
                "fill": "Bütün hücreleri <i>%d<\/i> ile doldur"
            },
            "buttons": {
                "collection": "Koleksiyon <span class=\"ui-button-icon-primary ui-icon ui-icon-triangle-1-s\"><\/span>",
                "colvis": "Sütun görünürlüğü",
                "colvisRestore": "Görünürlüğü eski haline getir",
                "copySuccess": {
                    "1": "1 satır panoya kopyalandı",
                    "_": "%ds satır panoya kopyalandı"
                },
                "copyTitle": "Panoya kopyala",
                "csv": "CSV",
                "excel": "Excel",
                "pageLength": {
                    "-1": "Bütün satırları göster",
                    "1": "-",
                    "_": "%d satır göster"
                },
                "pdf": "PDF",
                "print": "Yazdır",
                "copy": "Kopyala",
                "copyKeys": "Tablodaki veriyi kopyalamak için CTRL veya u2318 + C tuşlarına basınız. İptal etmek için bu mesaja tıklayın veya escape tuşuna basın."
            },
            "infoPostFix": "-",
            "searchBuilder": {
                "add": "Koşul Ekle",
                "button": {
                    "0": "Arama Oluşturucu",
                    "_": "Arama Oluşturucu (%d)"
                },
                "condition": "Koşul",
                "conditions": {
                    "date": {
                        "after": "Sonra",
                        "before": "Önce",
                        "between": "Arasında",
                        "empty": "Boş",
                        "equals": "Eşittir",
                        "not": "Değildir",
                        "notBetween": "Dışında",
                        "notEmpty": "Dolu"
                    },
                    "number": {
                        "between": "Arasında",
                        "empty": "Boş",
                        "equals": "Eşittir",
                        "gt": "Büyüktür",
                        "gte": "Büyük eşittir",
                        "lt": "Küçüktür",
                        "lte": "Küçük eşittir",
                        "not": "Değildir",
                        "notBetween": "Dışında",
                        "notEmpty": "Dolu"
                    },
                    "string": {
                        "contains": "İçerir",
                        "empty": "Boş",
                        "endsWith": "İle biter",
                        "equals": "Eşittir",
                        "not": "Değildir",
                        "notEmpty": "Dolu",
                        "startsWith": "İle başlar"
                    },
                    "array": {
                        "contains": "İçerir",
                        "empty": "Boş",
                        "equals": "EşiUrltir",
                        "not": "Değildir",
                        "notEmpty": "Dolu",
                        "without": "Hariç"
                    }
                },
                "data": "Veri",
                "deleteTitle": "Filtreleme kuralını silin",
                "leftTitle": "Kriteri dışarı çıkart",
                "logicAnd": "ve",
                "logicOr": "veya",
                "rightTitle": "Kriteri içeri al",
                "title": {
                    "0": "Arama Oluşturucu",
                    "_": "Arama Oluşturucu (%d)"
                },
                "value": "Değer",
                "clearAll": "Filtreleri Temizle"
            },
            "searchPanes": {
                "clearMessage": "Hepsini Temizle",
                "collapse": {
                    "0": "Arama Bölmesi",
                    "_": "Arama Bölmesi (%d)"
                },
                "count": "{total}",
                "countFiltered": "{shown}\/{total}",
                "emptyPanes": "Arama Bölmesi yok",
                "loadMessage": "Arama Bölmeleri yükleniyor ...",
                "title": "Etkin filtreler - %d"
            },
            "searchPlaceholder": "Ara",
            "thousands": ".",
            "datetime": {
                "amPm": [
                    "öö",
                    "ös"
                ],
                "hours": "Saat",
                "minutes": "Dakika",
                "next": "Sonraki",
                "previous": "Önceki",
                "seconds": "Saniye",
                "unknown": "Bilinmeyen"
            },
            "decimal": ",",
            "editor": {
                "close": "Kapat",
                "create": {
                    "button": "Yeni",
                    "submit": "Kaydet",
                    "title": "Yeni kayıt oluştur"
                },
                "edit": {
                    "button": "Düzenle",
                    "submit": "Güncelle",
                    "title": "Kaydı düzenle"
                },
                "error": {
                    "system": "Bir sistem hatası oluştu (Ayrıntılı bilgi)"
                },
                "multi": {
                    "info": "Seçili kayıtlar bu alanda farklı değerler içeriyor. Seçili kayıtların hepsinde bu alana aynı değeri atamak için buraya tıklayın; aksi halde her kayıt bu alanda kendi değerini koruyacak.",
                    "noMulti": "Bu alan bir grup olarak değil ancak tekil olarak düzenlenebilir.",
                    "restore": "Değişiklikleri geri al",
                    "title": "Çoklu değer"
                },
                "remove": {
                    "button": "Sil",
                    "confirm": {
                        "_": "%d adet kaydı silmek istediğinize emin misiniz?",
                        "1": "Bu kaydı silmek istediğinizden emin misiniz?"
                    },
                    "submit": "Sil",
                    "title": "Kayıtları sil"
                }
            }
        }
    });

    /*DataTable Ends*/


    /*Ajax Get _UserAddPartial*/
    $(function () {
        const placeHolderDiv = $("#modelPlaceHolder");
        const url = "/Admin/User/Add";

        $("#btnAdd").click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal("show");
            });
        });

        /*Ajax POST*/
        placeHolderDiv.on("click", "#btnSave", function (event) {

            /*Submit işlemini engelliyoruz*/
            event.preventDefault();

            const form = $("#form-user-add");
            const actionUrl = form.attr("action");

            /*IFormFile nesnesini düzenlemeyebilmek için bu şekilde tanımladık*/
            const dataToSend = new FormData(form.get(0));


            $.ajax({
                url: actionUrl,
                type: "POST",
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    const userAddAjaxModel = jQuery.parseJSON(data);
                    const newFormBody = $(".modal-body", userAddAjaxModel.UserAddPartial);
                    placeHolderDiv.find(".modal-body").replaceWith(newFormBody);
                    const isValid = newFormBody.find("[name='IsValid']").val() === "True";

                    if (isValid) {
                        placeHolderDiv.find(".modal").modal("hide");
                        /*Data Table Fonksiyonu Aracılığıyla ekledik*/
                        const newTableRow = dataTable.row.add([
                            userAddAjaxModel.UserDto.User.Id,
                            userAddAjaxModel.UserDto.User.UserName,
                            userAddAjaxModel.UserDto.User.Email,
                            userAddAjaxModel.UserDto.User.FirstName,
                            userAddAjaxModel.UserDto.User.LastName,
                            userAddAjaxModel.UserDto.User.PhoneNumber,
                            userAddAjaxModel.UserDto.User.About.length > 75 ? userAddAjaxModel.UserDto.User.About.substring(0, 75) : userAddAjaxModel.UserDto.User.About,
                            `<img src="/img/${userAddAjaxModel.UserDto.User.Picture}" alt="${userAddAjaxModel.UserDto.User.UserName}" class="my-image-table" />`,
                            `
                                <button class="btn btn-info btn-sm btn-detail" data-id="${userAddAjaxModel.UserDto.User.Id}"><span class="fas fa-newspaper"></span></button>
                                <button class="btn btn-warning btn-sm btn-assign" data-id="${userAddAjaxModel.UserDto.User.Id}"><span class="fas fa-user-shield"></span></button>
                                <button class="btn btn-primary btn-sm btn-update" data-id="${userAddAjaxModel.UserDto.User.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${userAddAjaxModel.UserDto.User.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                        ]).node(); //Node ile eklenen tr satırına erişebiliyoruz

                        const jqueryTableRow = $(newTableRow);
                        jqueryTableRow.attr("name", `${userAddAjaxModel.UserDto.User.Id}`);
                        dataTable.draw(); //Eklenen datayı tabloya uyarlıyoruz

                        toastr.success(`${userAddAjaxModel.UserDto.Message}`, "Başarılı İşlem!");
                    }
                    else {
                        let summaryText = "";
                        $("#validation-summary > ul > li").each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`
                        });
                        toastr.warning(summaryText);
                    }
                },
                error: function (err) {
                    toastr.error(`${err.responseText}`, "Hata!");
                }
            });
        });

    });

    /*Ajax POST DELETE*/
    $(document).on("click", ".btn-delete", function (event) {
        /*Submit işlemini engelliyoruz*/
        event.preventDefault();

        const id = $(this).attr("data-id");
        const tableRow = $(`[name="${id}"]`);
        const userName = tableRow.find("td:eq(1)").text();

        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${userName} adlı kullanıcıyı silmek istediğinize emin misiniz?`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, silmek istiyorum!',
            cancelButtonText: "Hayır,silmek istemiyorum!"
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: "POST",
                    data: {
                        userId: id
                    },
                    url: '/Admin/User/Delete',
                    success: function (deletedData) {

                        const userDto = jQuery.parseJSON(deletedData);
                        if (userDto.ResultStatus === 0) {

                            dataTable.row(tableRow).remove().draw();

                            Swal.fire(
                                'Silindi!',
                                `${userDto.User.UserName} adlı kullanıcı başarıyla silinmiştir`,
                                'success'
                            );


                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız İşlem!..',
                                text: `${userDto.Message}`
                            })
                        }
                    },
                    error: function (err) {
                        toastr.error(`${err.responseText}`, "Hata");
                    }
                });
            }
        })
    });

    /*Ajax GET UPDATE Partial*/
    $(function () {

        const url = "/Admin/User/Update";
        const placeHolderDiv = $("#modelPlaceHolder");

        $(document).on("click", ".btn-update", function (event) {
            event.preventDefault();
            const id = $(this).attr("data-id");
            //Get işlemiyle beraber parametre gönderiyoruz ve parametre isminin birebir aynı olması bizim için önemli
            $.get(url, { userId: id })
                .done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find(".modal").modal("show");
                }).fail(function (err) {
                    toastr.error(`${err.responseText}`, "Hata!");
                });
        });

        /*Ajax POST UPDATE*/
        placeHolderDiv.on("click", "#btnUpdate", function () {
            event.preventDefault();

            const form = $("#form-user-update");
            const actionUrl = form.attr("action");

            /*IFormFile nesnesini düzenlemeyebilmek için bu şekilde tanımladık*/
            const dataToSend = new FormData(form.get(0));


            $.ajax({
                url: actionUrl,
                type: "POST",
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    const userUpdateAjaxModel = jQuery.parseJSON(data);
                    console.log(userUpdateAjaxModel);
                    const newFormBody = $('.modal-body', userUpdateAjaxModel.UserUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const id = userUpdateAjaxModel.UserDto.User.Id;
                        const tableRow = $(`[name="${id}"]`);
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row(tableRow).data([
                            userUpdateAjaxModel.UserDto.User.Id,
                            userUpdateAjaxModel.UserDto.User.UserName,
                            userUpdateAjaxModel.UserDto.User.Email,
                            userUpdateAjaxModel.UserDto.User.FirstName,
                            userUpdateAjaxModel.UserDto.User.LastName,
                            userUpdateAjaxModel.UserDto.User.PhoneNumber,
                            userUpdateAjaxModel.UserDto.User.About.length > 75 ? userUpdateAjaxModel.UserDto.User.About.substring(0, 75) : userUpdateAjaxModel.UserDto.User.About,
                            `<img src="/img/${userUpdateAjaxModel.UserDto.User.Picture}" alt="${userUpdateAjaxModel.UserDto.User.UserName}" class="my-image-table" />`,
                            `
                                <button class="btn btn-info btn-sm btn-detail" data-id="${userUpdateAjaxModel.UserDto.User.Id}"><span class="fas fa-newspaper"></span></button>
                                <button class="btn btn-warning btn-sm btn-assign" data-id="${userUpdateAjaxModel.UserDto.User.Id}"><span class="fas fa-user-shield"></span></button>
                                <button class="btn btn-primary btn-sm btn-update" data-id="${userUpdateAjaxModel.UserDto.User.Id}"><span class="fas fa-edit"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${userUpdateAjaxModel.UserDto.User.Id}"><span class="fas fa-minus-circle"></span></button>
                            `
                        ]);
                        tableRow.attr("name", `${id}`);
                        dataTable.row(tableRow).invalidate();
                        toastr.success(`${userUpdateAjaxModel.UserDto.Message}`, "Başarılı İşlem!");
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                    }
                },
                error: function (err) {
                    toastr.error(`${err.responseText}`, "Hata!");
                }
            });


        });


    });



    // Get Detail Ajax Operation
    $(function () {

        const url = '/Admin/User/GetDetail/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click',
            '.btn-detail',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { userId: id }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function (err) {
                    toastr.error(`${err.responseText}`, 'Hata!');
                });
            });

    });


    /*Ajax GET Assign Partial*/
    $(function () {

        const url = "/Admin/Role/Assign";
        const placeHolderDiv = $("#modelPlaceHolder");

        $(document).on("click", ".btn-assign", function (event) {
            event.preventDefault();
            const id = $(this).attr("data-id");
            //Get işlemiyle beraber parametre gönderiyoruz ve parametre isminin birebir aynı olması bizim için önemli
            $.get(url, { userId: id })
                .done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find(".modal").modal("show");
                }).fail(function (err) {
                    toastr.error(`${err.responseText}`, "Hata!");
                });
        });

        /*Ajax POST Assign*/
        placeHolderDiv.on("click", "#btnAssignPost", function () {
            event.preventDefault();

            const form = $("#form-role-assign");
            const actionUrl = form.attr("action");

            const dataToSend = new FormData(form.get(0));


            $.ajax({
                url: actionUrl,
                type: "POST",
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    const userRoleAssignAjaxModel = jQuery.parseJSON(data);
                    console.log(userRoleAssignAjaxModel);
                    const newFormBody = $('.modal-body', userRoleAssignAjaxModel.RoleAssignPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        const id = userRoleAssignAjaxModel.UserDto.User.Id;
                      
                        placeHolderDiv.find('.modal').modal('hide');
               
                        toastr.success(`${userRoleAssignAjaxModel.UserDto.Message}`, "Başarılı İşlem!");
                    } else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                    }
                },
                error: function (err) {
                    toastr.error(`${err.responseText}`, "Hata!");
                }
            });


        });


    });



});