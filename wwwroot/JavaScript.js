function LoadVinyls() {
    fetch("api/vinyls", {
        method:"GET"
    }).then(r => {
        if (!r.ok) {
            throw new Error("hálózati hiba" + r)
        }
        return r.json();
    }).then(data => {
        FillTable(data);
    }).catch(e => {
        console.log(e)
    })
}

LoadVinyls();

function FillTable(data) {
    var table = document.getElementById("tableForContent")
    for (var i = 0; i < data.length; i++) {
        var row = document.createElement("tr");
        var currentRow = data[i];

        for (var j in currentRow) {
            var column = document.createElement("td");
            column.textContent = currentRow[j];

            row.appendChild(column);
        }
        table.appendChild(row)
    }
}

document.getElementById("deleteButton").addEventListener("click", () => {
    var id = parseInt(document.getElementById("deleteVinylId").value);
    if (id < 0 || isNaN(id)) {
        alert("nem helyes ID formátum");
        return;
    }

    fetch(`api/vinyls/${id}`, {
        method: "DELETE"
    }).then(r => {
        if (r.ok) {
            alert("Sikeres törlés");
            LoadVinyls();
        }
        else {
            alert("sikertelen törlés")
        }
    })
})