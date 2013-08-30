/// <reference group="Dedicated Worker" />
self.importScripts("/js/helpers/calculations.js");

onmessage = function(event) {
    var result = self.calculations.primeFromRange(event.data.startNumber, event.data.endNumber);
    self.postMessage(result);
};
