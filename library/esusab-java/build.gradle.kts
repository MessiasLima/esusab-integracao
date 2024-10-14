import java.net.URI

plugins {
    id("java-library")
    id("maven-publish")
}

group = "br.gov.saude.esusab"
version = System.getenv("VERSION_ESUSAB_JAVA") ?: "0.0.1-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    // libthrift is already on 0.21.0, however the files were compiled using 0.9.3 version
    implementation("org.apache.thrift:libthrift:0.9.3")

    // javax.annotation-api:1.3.2 is dependency of libthrift:0.9.3. We must update it as soon as possible
    implementation("javax.annotation:javax.annotation-api:1.3.2")
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

    publications {
        create<MavenPublication>("maven") {
            from(components["java"])
        }
    }
}