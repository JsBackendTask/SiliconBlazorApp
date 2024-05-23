function resendCode(email) {
    fetch('https://verificationprovider-silicon-bnar.azurewebsites.net/api/Verify?code=GYUemekurKbemZgcZjQjK_WZHFRHCBUF6FHqAeYVq5BBAzFuDzsozw%3D%3D', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ Email: email })
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Error resending code');
            }
            return response.json();
        })
        .then(data => {
            console.log('Code resent');
        })
        .catch(error => {
            console.error('Error:', error);
        });
}