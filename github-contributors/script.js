(function () {
  var search = document.getElementById("contributor-search");
  var cards = Array.prototype.slice.call(document.querySelectorAll(".card"));
  var empty = document.getElementById("no-results");

  if (!search) {
    return;
  }

  function filterCards() {
    var query = search.value.trim().toLowerCase();
    var visible = 0;

    cards.forEach(function (card) {
      var haystack = (card.getAttribute("data-search") || "").toLowerCase();
      var match = !query || haystack.indexOf(query) !== -1;
      card.hidden = !match;
      if (match) {
        visible += 1;
      }
    });

    if (empty) {
      empty.classList.toggle("show", visible === 0);
    }
  }

  search.addEventListener("input", filterCards);
})();
