$(document).ready(function () {
    $('#Listagem').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "No data available in table",
            "info": "Mostrando _START_ de _END_ em um total de _TOTAL_ registros",
            "infoEmpty": "Mostrando 0 to 0 of 0 entries",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrando _MENU_ registros por pagina",
            "loadingRecords": "Loading...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Nenhum Registro Encontrado",
            "paginate": {
                "first": "Primeira",
                "last": "Ultima",
                "next": "Proxima",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Order by this column",
                "orderableReverse": "Reverse order this column"
            }
        }
    })


    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 2000)
});