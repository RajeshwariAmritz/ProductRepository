// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*window.setMobileTable = function (selector) {
    // if (window.innerWidth > 600) return false;
    const tableEl = document.querySelector(selector);
    const thEls = tableEl.querySelectorAll('thead th');
    const tdLabels = Array.from(thEls).map(el => el.innerText);
    tableEl.querySelectorAll('tbody tr').forEach(tr => {
        Array.from(tr.children).forEach(
            (td, ndx) => td.setAttribute('label', tdLabels[ndx])
        );
    });
}*/
<script >
    function reqconfirm() {
        {
            Swal.fire({
                title: "Do you want to save the changes?",
                showDenyButton: true,
                showCancelButton: true,
                confirmButtonText: "Save",
                denyButtonText: `Don't save`
            }).then((result) => {
                /* Read more about isConfirmed, isDenied below */
                if (result.isConfirmed) {
                    Swal.fire("Saved!", "", "success");
                } else if (result.isDenied) {
                    Swal.fire("Changes are not saved", "", "info");
                }
            });
}
    }
    {/*function requestConfirmation(){
        swal("Are You want To Update", {
            dangerMode: true,
            buttons: true,
        })
    }*/}
</script>