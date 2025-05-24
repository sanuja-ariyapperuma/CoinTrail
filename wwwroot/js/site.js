// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

<script>
    document.body.addEventListener("htmx:beforeRequest", function (evt) {
        const el = evt.target;

    // Only target forms with a validation handler
    if (el.tagName === "FORM" && el.dataset.validate) {
            const validatorFn = window[el.dataset.validate];
    if (typeof validatorFn === "function") {
                const result = validatorFn(el);
    if (!result) {
        evt.preventDefault();
                }
            }
        }
    });
</script>