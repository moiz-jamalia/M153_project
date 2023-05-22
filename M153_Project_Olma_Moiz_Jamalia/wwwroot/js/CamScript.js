document.addEventListener('DOMContentLoaded', (event) => {
    Webcam.set({
        Width: 400,
        height: 350,
        image_format: 'jpeg',
        jpeg_quality: 90
    });

    var camera = document.getElementById("camera");

    if (camera) Webcam.attach(camera);

    const captureButton = document.getElementById('capture-btn');
    const cameraContainer = document.getElementById('camera-container');
    const formContainer = document.getElementById('form-container');
    const imageDataInput = document.getElementById('ImageData');

    captureButton.addEventListener('click', () => {
        Webcam.snap(function (dataUri) {
            const capturedImage = document.getElementById('captured-image');
            capturedImage.src = dataUri;
            captureButton.style.display = 'none';
            cameraContainer.style.display = 'none';
            capturedImage.style.display = 'block';
            formContainer.style.display = 'block';

            const formData = new FormData();

            const blob = dataURItoBlob(dataUri);
            formData.append('ImageData', blob);

            const firstNameInput = document.getElementById('firstName');
            const lastNameInput = document.getElementById('lastName');

            formData.append('FirstName', firstNameInput.value);
            formData.append('LastName', lastNameInput.value);

            fetch('@Url.Action("CreateUser", "HomeScreenController")', {
                method: 'POST',
                body: formData
            }).then(response => {

                if (response.ok) console.log('User created successfully');
                else console.error('Failed to create user');

            }).catch(error => {
                console.error('An error occurred:', error);
            });
        });
    });
});