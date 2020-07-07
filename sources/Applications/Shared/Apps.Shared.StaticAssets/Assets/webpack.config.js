﻿const path = require('path');

module.exports = (env, args) => ({
     resolve: { extensions: ['.ts', '.js'] },
     devtool: args.mode === 'development' ? 'source-map' : 'none',
     module: {
          rules: [{ test: /\.ts?$/, loader: 'ts-loader' }]
     },
     entry: './BlazorChartist.ts',
     output: {
          // Place output in wwwroot and export a top-level 'BlazorChartist' object
          path: path.join(__dirname, '..', 'wwwroot', 'libraries', 'chartist', 'scripts'),
          filename: 'BlazorChartist.js',
          libraryTarget: 'var',
          library: 'BlazorChartist',
          libraryExport: 'default'
     }
});