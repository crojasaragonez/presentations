import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import { ApolloClient, InMemoryCache } from "@apollo/client/core";
import { createApolloProvider } from "@vue/apollo-option";
import { autoAnimatePlugin } from "@formkit/auto-animate/vue";
import { library } from "@fortawesome/fontawesome-svg-core";
import { FontAwesomeIcon } from "@fortawesome/vue-fontawesome";
import { faXmark, faCheck, faSpinner } from "@fortawesome/free-solid-svg-icons";
library.add(faXmark, faCheck, faSpinner);
import "./assets/main.css";

const cache = new InMemoryCache();

const apolloClient = new ApolloClient({
  cache,
  uri: "http://golabs.localhost:8000/graphql",
  headers: {
    authorization: `Bearer ${localStorage.getItem("api_token")}`,
  },
});

const apolloProvider = createApolloProvider({
  defaultClient: apolloClient,
});

const app = createApp(App);

app.use(apolloProvider);
app.use(autoAnimatePlugin);
app.component("font-awesome-icon", FontAwesomeIcon);

app.use(router);

app.mount("#app");
