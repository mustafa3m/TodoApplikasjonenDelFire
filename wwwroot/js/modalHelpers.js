window.modalHelpers = {
    showModal: function (modalId) {
        var modalElement = document.getElementById(modalId);
        if (modalElement) {
            var modal = new bootstrap.Modal(modalElement);
            modal.show();
        } else {
            console.error(`Modal with ID ${modalId} not found.`);
        }
    },
    hideModal: function (modalId) {
        var modalElement = document.getElementById(modalId);
        if (modalElement) {
            var modal = bootstrap.Modal.getInstance(modalElement);
            if (modal) {
                modal.hide();
            } else {
                console.error(`No instance of modal with ID ${modalId} found.`);
            }
        } else {
            console.error(`Modal with ID ${modalId} not found.`);
        }
    }
};
