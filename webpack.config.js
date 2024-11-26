const path = require('path');

module.exports = {
	entry: './index.js',
	output: {
		filename: 'main.js',
		path: path.resolve(__dirname, './src/BlazorApp/wwwroot/dist/')
	},
	mode: 'production',
	watchOptions: {
		ignored: '**/node_modules',
	},
	devtool: 'source-map',
};
