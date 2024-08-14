$(document).ready(function () {
    $('#lista').DataTable({
        language: {
        "decimal": "",
        "emptyTable": "Nenhum dado disponível na tabela",
        "info": "Mostrando _START_ a _END_ de _TOTAL_ registros",
        "infoEmpty": "Mostrando 0 a 0 de 0 registros",
        "infoFiltered": "(filtrado de _MAX_ registros totais)",
        "infoPostFix": "",
        "thousands": ",",
        "lengthMenu": "Mostrando _MENU_ registros por página",
        "loadingRecords": "Carregando...",
        "processing": "Processando...",
        "search": "Procurar:",
        "zeroRecords": "Nenhum registro encontrado",
        "paginate": {
            "first": "Primeira",
            "last": "Última",
            "next": "Próxima",
            "previous": "Anterior"
        },
        "aria": {
            "sortAscending": ": ativar para ordenar a coluna de forma ascendente",
            "sortDescending": ": ativar para ordenar a coluna de forma descendente"
        }
    }
});
    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        });
    }, 2000)

});

function openDeleteModal(id) {
    document.getElementById('deleteId').value = id;
    var deleteModal = new bootstrap.Modal(document.getElementById('deleteModal'));
    deleteModal.show();
}

const hamBurger = document.querySelector(".toggle-btn");
hamBurger.addEventListener("click", function () {
    console.log("Hamburger clicked");
    document.querySelector("#sidebar").classList.toggle("expand");
});


