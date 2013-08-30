/// <reference group="Dedicated Worker" />
self.importScripts("/js/helpers/calculations.js");

onmessage = function(event) {
    var result = self.calculations.primeNumberTo(event.data.toNumber);
    self.postMessage(result);
};
