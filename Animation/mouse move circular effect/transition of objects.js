let move = document.getElementById('move');
let remove = document.getElementById('remove');

move.addEventListener('click', function(e) {
    let objs = document.querySelectorAll('div');
    objs.forEach((o) => {
        o.classList.toggle('moved');
    });
});

remove.addEventListener('click', function(e) {
    let objs = document.querySelectorAll('div');
    objs.forEach((o) => {
        o.classList.toggle('removed');
    });
});

