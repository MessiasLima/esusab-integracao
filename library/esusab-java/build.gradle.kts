import java.net.URI

plugins {
    id("java-library")
    id("maven-publish")
}

group = "br.gov.saude.esusab"
version = System.getenv("VERSION_ESUSAB_JAVA") ?: "1.0-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    testImplementation(platform("org.junit:junit-bom:5.10.0"))
    testImplementation("org.junit.jupiter:junit-jupiter")
}

val repo: String = System.getenv("GITHUB_REPOSITORY") ?: "laboratoriobridge/esusab-integracao"

publishing {
    repositories {
        maven {
            name = "GitHubPackages"
            url = URI("https://maven.pkg.github.com/$repo")
            credentials {
                username = System.getenv("GITHUB_ACTOR")
                password = System.getenv("GITHUB_TOKEN")
            }
        }
    }
}