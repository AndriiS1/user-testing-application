import api from "./api";
import TokenService from "./token.service";
import {get_all_tests_route, get_test_questions_with_answers, get_tests_route} from '../ApiRoutes/apiRoutes';

class TestService {
    GetAllTests() {
        return api
            .get(get_all_tests_route)
            .then(response => {
                if (response.data.accessToken) {
                    TokenService.setUserTokens({
                        accessToken: response.data.accessToken,
                        refreshToken: response.data.refreshToken
                    });
                }

                return response.data;
            });
    }

    GetTest(testId:number) {
        return api
            .get(`${get_tests_route}?testId=${testId}`)
            .then(response => {
                if (response.data.accessToken) {
                    TokenService.setUserTokens({
                        accessToken: response.data.accessToken,
                        refreshToken: response.data.refreshToken
                    });
                }

                return response.data;
            });
    }

    GetTestQuestionsWithAnswers(testId:number) {
        return api
            .get(`${get_test_questions_with_answers}?testId=${testId}`)
            .then(response => {
                if (response.data.accessToken) {
                    TokenService.setUserTokens({
                        accessToken: response.data.accessToken,
                        refreshToken: response.data.refreshToken
                    });
                }

                return response.data;
            });
    }
}

export default new TestService();