module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            colors: {
                light: {
                    background: "#ffffff",
                    text: "#000000",
                },
                dark: {
                    background: "#1a202c",
                    text: "#ffffff",
                },
            },
        },
    },
    darkMode: 'selector',
    plugins: [],
};