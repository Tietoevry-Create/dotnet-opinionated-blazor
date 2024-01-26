module.exports = {
	content: [
		'./src/**/*.razor',
		'./src/**/*.html',
		'./src/**/*.cshtml',
		'./src/**/*.cs',
	],
	safelist: [
		'progress-bar',
	],
	theme: {
		extend: {
			fontFamily: {
				sans: ['Inter var', 'Arial', 'Helvetica', 'sans-serif'],
			},
		},
	},
	plugins: [
		require('@tailwindcss/forms'),
		require('@tailwindcss/typography'),
	],
}