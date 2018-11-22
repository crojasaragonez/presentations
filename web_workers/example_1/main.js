var worker = new Worker('worker.js');
worker.onmessage = (event) => {
  console.log(event.data);
};

worker.postMessage({question: 'What time is it?'});
