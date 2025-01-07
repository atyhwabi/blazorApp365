"use strict";

console.log("Site.js loaded")
function downloadFile(fileName, contentType, content) {
  var link = document.createElement('a');
  link.href = `data:${contentType};base64,${content}`;
  link.download = fileName;
  document.body.appendChild(link);
  link.click();
  document.body.removeChild(link);
}