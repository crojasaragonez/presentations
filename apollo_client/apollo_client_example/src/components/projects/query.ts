import gql from "graphql-tag";

import PROJECT_FRAGMENT from "./fragment";

export default gql`
  query ($name: String) {
    projects(orderBy: [{ column: "created_at", order: DESC }], name: $name) {
      paginatorInfo {
        hasMorePages
      }
      data {
        ...project
      }
    }
  }
  ${PROJECT_FRAGMENT}
`;
