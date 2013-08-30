/// <reference group="Dedicated Worker" />
self.importScripts("/js/helpers/calculations.js");

onmessage = function(event) {
    var result = self.calculations.primeFirstNumbers(event.data.toNumber, event.data.stopNumber);
    self.postMessage(result);
};
