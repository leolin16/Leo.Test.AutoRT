const webpack = require('webpack');
var path = require('path');
const ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = [
    {
        entry: {
            'bundle': './ClientApp/app.js',
        },

        output: {
            path: path.resolve('./wwwroot'),
            filename: '[name].js'
        },

        resolve: {
            extensions: [".webpack.js", ".web.js", ".mjs", ".js", ".json"]
        },

        module: {
            rules: [
                {
                    test: /\.mjs$/,
                    include: /node_modules/,
                    type: "javascript/auto",
                },
                { test: /\.js/, use: [{
                    loader: 'babel-loader'
                }], exclude: /node_modules/ },
                {
                    test: /\.css$/, use: ExtractTextPlugin.extract({
                        fallback: "style-loader",
                        use: "css-loader"
                    })
                },
                { test: /\.flow/, use: [{
                    loader: 'ignore-loader'
                }] }
            ]
        },

        plugins: [
            new ExtractTextPlugin('style.css', { allChunks: true })
        ]
    }
];